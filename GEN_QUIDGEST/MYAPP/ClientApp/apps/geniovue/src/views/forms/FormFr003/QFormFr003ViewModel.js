/* eslint-disable @typescript-eslint/no-unused-vars */
import { computed, reactive, watch } from 'vue'
import _merge from 'lodash-es/merge'

import FormViewModelBase from '@/mixins/formViewModelBase.js'
import genericFunctions from '@quidgest/clientapp/utils/genericFunctions'
import modelFieldType from '@quidgest/clientapp/models/fields'

import hardcodedTexts from '@/hardcodedTexts.js'
import netAPI from '@quidgest/clientapp/network'
import qApi from '@/api/genio/quidgestFunctions.js'
import qFunctions from '@/api/genio/projectFunctions.js'
import qProjArrays from '@/api/genio/projectArrays.js'
/* eslint-enable @typescript-eslint/no-unused-vars */

/**
 * Represents a ViewModel class.
 * @extends FormViewModelBase
 */
export default class ViewModel extends FormViewModelBase
{
	/**
	 * Creates a new instance of the ViewModel.
	 * @param {object} vueContext - The Vue context
	 * @param {object} options - The options for the ViewModel
	 * @param {object} values - A ViewModel instance to copy values from
	 */
	// eslint-disable-next-line @typescript-eslint/no-unused-vars
	constructor(vueContext, options, values)
	{
		super(vueContext, options)
		// eslint-disable-next-line @typescript-eslint/no-unused-vars
		const vm = this.vueContext

		// The view model metadata
		_merge(this.modelInfo, {
			name: 'FR_003',
			area: 'T_003',
			actions: {
				recalculateFormulas: 'RecalculateFormulas_Fr_003',
				updateFilesTickets: 'UpdateFilesTicketsFr_003',
				setFile: 'SetFileFr_003'
			}
		})

		/** The primary key. */
		this.ValCodt_003 = reactive(new modelFieldType.PrimaryKey({
			id: 'ValCodt_003',
			originId: 'ValCodt_003',
			area: 'T_003',
			field: 'CODT_003',
			description: '',
		}).cloneFrom(values?.ValCodt_003))
		this.stopWatchers.push(watch(() => this.ValCodt_003.value, (newValue, oldValue) => this.onUpdate('t_003.codt_003', this.ValCodt_003, newValue, oldValue)))

		/** The remaining form fields. */
		this.ValCountry = reactive(new modelFieldType.String({
			id: 'ValCountry',
			originId: 'ValCountry',
			area: 'T_003',
			field: 'F_001',
			maxLength: 50,
			description: computed(() => this.Resources.COUNTRY_NAME26113),
		}).cloneFrom(values?.ValCountry))
		this.stopWatchers.push(watch(() => this.ValCountry.value, (newValue, oldValue) => this.onUpdate('t_003.country', this.ValCountry, newValue, oldValue)))
	}

	/**
	 * Creates a clone of the current QFormFr003ViewModel instance.
	 * @returns {QFormFr003ViewModel} A new instance of QFormFr003ViewModel
	 */
	clone()
	{
		return new ViewModel(this.vueContext, { callbacks: this.externalCallbacks }, this)
	}

	static QPrimaryKeyName = 'ValCodt_003'

	get QPrimaryKey() { return this.ValCodt_003.value }
	set QPrimaryKey(value) { this.ValCodt_003.updateValue(value) }
}
